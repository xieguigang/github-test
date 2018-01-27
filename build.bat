@echo off

REM build markdown source from .NET xml assembly file
REM "App\xDoc.exe" /Build /in "./App/" /lib xdoc /vb_spec.exclude /out "./post/"

REM build statics html website
"App\Yilia.exe" /build /wwwroot "./" /publish "./publish" /post.folder docs