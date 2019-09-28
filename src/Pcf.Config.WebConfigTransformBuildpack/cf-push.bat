cf target -s pcf-config
pause
@cls

cf delete pcf-config-web-config-transform-buildpack -r -f
pause
@cls

cf push
pause
@cls