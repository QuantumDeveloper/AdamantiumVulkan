# Regenerates the package icons. Kept in the repository rather than the icons being dropped in by hand, so the
# scheme is reproducible and arguable: change a colour or a code here and every icon follows.
#
# The scheme: one mark for the family - the letter, cut like metal, since adamantium is an alloy and not a crystal -
# and a code band naming the member. Colour alone was tried and rejected: it cannot be read without effort, and it
# fails outright for anyone who does not separate blue from violet. The code works in greyscale.
#
# Nothing here derives from the Vulkan logo or any Khronos mark; those are trademarks and do not belong in a package
# icon.
#
# Usage:  pwsh build/make-icons.ps1        (writes icon.png beside each packable csproj)

Add-Type -AssemblyName System.Drawing

$root = Split-Path $PSScriptRoot -Parent
$S = 512          # drawn at this size
$F = 128          # what nuget.org asks for
$bandTop = 356
$bandH = $S - $bandTop
$pad = 34

function Get-Tile-Path {
    param([int]$r = 104)
    $p = New-Object System.Drawing.Drawing2D.GraphicsPath
    $d = $r * 2
    $p.AddArc(0, 0, $d, $d, 180, 90)
    $p.AddArc($S - $d, 0, $d, $d, 270, 90)
    $p.AddArc($S - $d, $S - $d, $d, $d, 0, 90)
    $p.AddArc(0, $S - $d, $d, $d, 90, 90)
    $p.CloseFigure()
    return $p
}

function New-Points {
    param($pairs)
    $arr = foreach ($p in $pairs) { New-Object System.Drawing.PointF ([float]$p[0]), ([float]$p[1]) }
    return [System.Drawing.PointF[]]$arr
}

function New-Icon {
    param([string]$project, [string]$code, [string]$light, [string]$dark)

    $bmp = New-Object System.Drawing.Bitmap $S, $S
    $g = [System.Drawing.Graphics]::FromImage($bmp)
    $g.SmoothingMode = [System.Drawing.Drawing2D.SmoothingMode]::AntiAlias
    $g.TextRenderingHint = [System.Drawing.Text.TextRenderingHint]::AntiAliasGridFit
    $g.CompositingQuality = [System.Drawing.Drawing2D.CompositingQuality]::HighQuality

    $tile = Get-Tile-Path
    $g.SetClip($tile)

    $rect = New-Object System.Drawing.Rectangle 0, 0, $S, $S
    $body = New-Object System.Drawing.Drawing2D.LinearGradientBrush(
        $rect,
        [System.Drawing.ColorTranslator]::FromHtml($light),
        [System.Drawing.ColorTranslator]::FromHtml($dark),
        [System.Drawing.Drawing2D.LinearGradientMode]::ForwardDiagonal)
    $g.FillRectangle($body, $rect)
    $body.Dispose()

    # A sweep of light across the plate. Without it the fill reads as paper rather than as a polished surface.
    $sheen = New-Object System.Drawing.SolidBrush ([System.Drawing.Color]::FromArgb(28, 255, 255, 255))
    $g.FillPolygon($sheen, (New-Points @(@(-40,210), @(290,-40), @(410,-40), @(-40,380))))
    $sheen.Dispose()

    # Flat apex, straight bevels, no curves - machined rather than typeset. The right leg carries a shade so the
    # letter sits under one light source with the plate instead of floating on it.
    $ink = New-Object System.Drawing.SolidBrush ([System.Drawing.Color]::FromArgb(255, 255, 255, 255))
    $shade = New-Object System.Drawing.SolidBrush ([System.Drawing.Color]::FromArgb(58, 0, 0, 0))
    $g.FillPolygon($ink, (New-Points @(@(238,74), @(276,74), @(312,196), @(262,196), @(212,330), @(140,330))))
    $g.FillPolygon($ink, (New-Points @(@(276,74), @(372,330), @(300,330), @(266,196))))
    $g.FillPolygon($shade, (New-Points @(@(276,74), @(372,330), @(300,330), @(266,196))))
    $g.FillPolygon($ink, (New-Points @(@(204,238), @(300,238), @(320,283), @(186,283))))
    $ink.Dispose(); $shade.Dispose()

    # Darkened plate, not a second colour: it reads as a recess milled into the metal rather than a label stuck on.
    $band = New-Object System.Drawing.SolidBrush ([System.Drawing.Color]::FromArgb(118, 0, 0, 0))
    $g.FillRectangle($band, 0, $bandTop, $S, $bandH)
    $band.Dispose()

    # Fitted to the band, not set at a fixed size: codes run from two letters to six, and one size cannot serve both.
    $probe = New-Object System.Drawing.Font 'Segoe UI', 100, ([System.Drawing.FontStyle]::Bold), ([System.Drawing.GraphicsUnit]::Pixel)
    $m = $g.MeasureString($code, $probe)
    $probe.Dispose()
    $scale = [Math]::Min(($S - 2 * $pad) / $m.Width, ($bandH - 30) / $m.Height)
    $size = [Math]::Max(34, [Math]::Min(112, [int](100 * $scale)))

    $font = New-Object System.Drawing.Font 'Segoe UI', $size, ([System.Drawing.FontStyle]::Bold), ([System.Drawing.GraphicsUnit]::Pixel)
    $fmt = New-Object System.Drawing.StringFormat
    $fmt.Alignment = [System.Drawing.StringAlignment]::Center
    $fmt.LineAlignment = [System.Drawing.StringAlignment]::Center
    $tb = New-Object System.Drawing.SolidBrush ([System.Drawing.Color]::FromArgb(255, 255, 255, 255))
    $g.DrawString($code, $font, $tb, (New-Object System.Drawing.RectangleF $pad, $bandTop, ($S - 2 * $pad), $bandH), $fmt)
    $font.Dispose(); $fmt.Dispose(); $tb.Dispose()

    $g.ResetClip(); $tile.Dispose()

    # The bevel on the edge itself: light along the top, dark along the bottom, so the plate has thickness.
    $edgeLight = New-Object System.Drawing.Pen ([System.Drawing.Color]::FromArgb(115, 255, 255, 255)), 10
    $edgeDark = New-Object System.Drawing.Pen ([System.Drawing.Color]::FromArgb(85, 0, 0, 0)), 10
    $inner = Get-Tile-Path
    $g.SetClip($inner)
    $g.DrawPath($edgeLight, $inner)
    $g.SetClip((New-Object System.Drawing.Rectangle 0, ([int]($S / 2)), $S, ([int]($S / 2))), [System.Drawing.Drawing2D.CombineMode]::Intersect)
    $g.DrawPath($edgeDark, $inner)
    $g.ResetClip(); $edgeLight.Dispose(); $edgeDark.Dispose(); $inner.Dispose()

    # Drawn large and shrunk: straight at 128 the diagonals of the letter come out ragged.
    $dir = Join-Path $root $project
    $final = New-Object System.Drawing.Bitmap $F, $F
    $fg = [System.Drawing.Graphics]::FromImage($final)
    $fg.InterpolationMode = [System.Drawing.Drawing2D.InterpolationMode]::HighQualityBicubic
    $fg.PixelOffsetMode = [System.Drawing.Drawing2D.PixelOffsetMode]::HighQuality
    $fg.DrawImage($bmp, 0, 0, $F, $F)
    $final.Save((Join-Path $dir 'icon.png'), [System.Drawing.Imaging.ImageFormat]::Png)
    $fg.Dispose(); $final.Dispose()

    # The large one stays out of the packages - it is for a README or a repository banner, where 128 is too small.
    $bmp.Save((Join-Path $PSScriptRoot "$project-512.png"), [System.Drawing.Imaging.ImageFormat]::Png)
    $bmp.Dispose(); $g.Dispose()

    "{0,-28} {1,-8} {2} px" -f $project, $code, $size
}

# One colour for the repository, one code per package: colour says where it comes from, the code says which it is.
$light = '#FF4A86E8'
$dark = '#FF1B4A96'

New-Icon 'Adamantium.Vulkan'        'VK'     $light $dark
New-Icon 'Adamantium.Vulkan.Loader' 'LOADER' $light $dark
New-Icon 'Adamantium.Vulkan.Slang'  'SLANG'  $light $dark
New-Icon 'Adamantium.Vulkan.Spirv'  'SPV'    $light $dark
