The setup for the Tailwindcss is done following this guide:
https://codewithmukesh.com/blog/integrating-tailwind-css-with-blazor/

Note also that the following

    <Target Name="PostBuild" AfterTargets="PostBuildEvent">
        <Exec Command="npm run buildcss" />
    </Target>

have been added to S05-Ex02_AuthWithTailwind.csproj
you might have to open folder in file explorer to see this file!

This will rebuild the css file with only the classes needed from tailwind!