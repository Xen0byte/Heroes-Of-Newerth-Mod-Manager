# C# mod manager for Heroes of Newerth

## About HoN Mod Manager

The HoN mod manager is a tool to make applying mods easier. It takes files in the [honmod](#honmod-file-format) format, which describes how a mod should be applied and which files should be modified, and then applies them automatically for you.

This is currently the primary way to create, share, and apply mods. Modern mods should be created using the format described below.

## Using HoN Mod Manager

Place all of your `.honmod` files in the `mods` subdirectory of your installation (e.g. `C:\Program Files (x86)\Heroes of Newerth\extensions\mods` or `C:\Program Files\Heroes of Newerth x64\extensions\mods`).

Then launch the `HoN Mod Manager.exe`. (If you are on Windows, be sure to run this as adminstrator in order to have the permissions it needs.)

The UI should be pretty intuitive.

You can select which mod(s) to `enable` or `disable`. This informs the manager of what changes should be staged.

Then, once you're ready, you can `apply` these selections to actually modify the HoN files.

NOTE: You will need to re-apply the mods any time the game is updated.

## honmod file format

Just like an `.s2z` a `.honmod` is a renamed (uncompressed) `.zip`. It contains the following files:

- `mod.xml`: A valid XML file with describing "how the mod is applied", that is where to add/edit/delete code from the original files. There is a very detailed documentation given below, but you might as well just try looking at other mods to understand how this file works.
- `icon.png`: A 48x48 icon to be displayed next to the mod's name in the mod manager. Note that partial transparency may not work or look really bad. This file is optional.
- Any supportive files, e.g. new files your mod adds. You need to reference these in `mod.xml` or they will be ignored.

### File structure

```xml
<?xml version="1.0" encoding="UTF-8"?>
<modification
    application="Heroes of Newerth"        fixed
    appversion="0.3"                       game version requirement (shown is "anything starting with 0.3")
    mmversion="1.3"                        fixed, the version of the file format
    name="The Mod's Name"                  It is strongly recommended to keep this name consistent as it will identify the mod.
    version="1.0"                          The current version of the mod. Should grow with each new release.
    description="blahblahblah"             Explanatory text about the mod to be shown when selected in the Mod Manager (optional)
    author="Your Nickname"                 Will be shown below the mod's name. (optional)
    weblink="http://www.com/"              A clickable link to be shown below the description text. (optional)
    updatecheckurl="http://.../version.txt"A URL to a text file containing the newest version number. (optional)
    updatedownloadurl="http://.../m.honmod"A URL to a .honmod file that will be downloaded and replace this mod file when the text file specified above contains a higher version number than this mod currently has. (optional)
>
    <!-- Of the elements being described below each kind may appear any number of times and in any order -->

    <incompatibility name="Other mod" version="1.0-1.4" />
    <!-- States an incompatibility with certain versions of another mod to be abided by the Mod Manager; this mod cannot be enabled when the other mod is enabled. -->

    <requirement name="Other mod" version="2.5.1-*" />
    <!-- States a dependence on another mod to be abided by the Mod Manager; this mod cannot be enabled when the other mod is not present and enabled. -->

    <applyafter name="Other mod" version="2.5.1-*" />
    <applybefore name="Other mod" version="2.5.1-*" />
    <!-- If the specified other mod is enabled, this mod will be applied after/before it. -->

    <copyfile name="path1" source="path2" overwrite="newer" version="1.0" condition="..." />
    <!-- Copies a supportive file from the mod archive. If "path2" is not specified the file "path1" is copied, if it is "path2" is copied and renamed to "path1".
         overwrite specifies a controlled behaviour in case the target file already exists:
         "yes"   -> target file is overwritten
         "no"    -> target file is left as is
         "newer" -> target file is overwritten if its version is lower than the one specified by the version attribute

        If the condition attribute is specified the copying is only performed if the given condition is true. A condition can consist of another mod being enabled or disabled or a boolean expression combining multiple such conditions. Examples of valid condition strings:
        'Tiny UI'
        not 'Tiny UI'
        'Tiny UI[v3.0]' and 'Automatic Ability Learner[v1.1-1.5]'
        ('BardUI' or ('Improved UI by Barter[v1.08]' and 'Improved UI Addon - Juking Map')) and not 'Tiny UI' -->

    <editfile name="path" condition="...">
        <!-- Edits a file from resources0.s2z or one that has already been copied
            If condition is specified this editfile tag is only executed if the given condition is true; uses the same syntax as for copyfile. -->

        <!-- Files are edited by executing a sequence of steps, each being represented by one of the four elements below.
             All elements need a string as input, which can either be delivered as inner text node (between the <operation></operation> tags) or read from a file in the mod archive specified by a source attribute.
             Every operation interacts with a "cursor" variable which points to a area in the file and starts out at the beginning of the file. -->

        <find position="end" /> <!-- synonyms for "find" are "seek" and "search" -->
        <!-- Moves the "cursor" to the next occurrence of the source string
             OR as specified by the position attribute, possible values being:
             "start"     -> Beginning of the file (synonyms: "begin", "head", "before")
             "end"       -> End of the file (synonyms: "tail", "after", "eof")
             any integer -> Move forward the specified number of characters (negative values allowed) -->
        <findup /> <!-- synonyms for "findup" are "seekup" and "searchup" -->
        <!-- Moves the "cursor" to the next occurrence of the source string, but searching backwards. -->

        <insert position="after" /> <!-- synonym for "insert" is "add" -->
        <!-- Inserts the source string at the "cursor", either before or after as the position attribute specifies. -->

        <replace />
        <!-- Replaces the string pointed to by the "cursor" with the source string. -->

        <delete />
        <!-- Deletes the string pointed to by the "cursor". Does not require a source string. -->
    </editfile>
</modification>
```

### Notes

- `version` values may only contain digits and periods. Any letters will be ignored!
- No two mods with the same name can be loaded at once.
- `requirement` tags allow mods of mods; such mods will always be applied *after* the mods they marked as required so that they may edit their code; note that `<requirement />` automatically implies `<applyafter />`.

## Understanding HoN Mods

### Background

HoN has always allowed [modding](https://en.wikipedia.org/wiki/Modding) of the game client for non-competitive gameplay. (Mods must be disabled to participate in tournaments).

A list of existing mods and other resources can be found on the [forums](https://forums.heroesofnewerth.com/index.php?/forum/10-modifications/).

### Understand the HoN UI

Essentially modding the HoN client allows users to add/remove/modify visual elements in the game to make for a better experience. For instance, there is the [Rune And Stack Timer mod](https://github.com/mrhappyasthma/HoN-RuneAndStackTimer) which alerts the user automatically when the game clock is approach time for a rune spawn or a creep stack.

So how exactly does modding work in HoN? Well, quite simply, it's done by editing the actual files used to display the HoN UI.

HoN uses files in the [XAML](https://en.wikipedia.org/wiki/Extensible_Application_Markup_Language) format (which is basically just a text file) to describe how the interface should look. The HoN game engine then parses these files and translates the textual description of the layout into the actual visual elements shown on screen.

For example, let's say you wanted to add a new button. You can do so by editing the existing file to add new XAML for your button. It might look something like this (it's okay if you don't understand the syntax, this is just a fictional example).

```xaml
<button color="#FFFFFF" x=50 y=50>
</button>
```

The files that describe the HoN UI can be found in the `Heroes of Newerth\game` directory, e.g. `C:\Program Files (x86)\Heroes of Newerth\game` or `C:\Program Files\Heroes of Newerth x64\game`.

If you go into that folder you should see some files with the `.s2z` file extension. This is a made-up file extension that is just an uncompressed `.zip` archive.

For example:

```
resources0.s2z
resources1.s2z
resources3.s2z
textures.s2z
```

If you want, you could copy any of these files and rename the copy from `.s2z` to `.zip`. Then you can extract the files from the archive and you can actually view all of the HoN resource files.

For example, inside `resources0.s2z` is the most of the code for the game client, such as the the UI, effects and sounds from the heroes, item-icons and more.

### How mods are applied

When you start the game, it wil load all "resourcesXXX.s2z" files, starting from the **lowest** number ()`0`), and working it's way upwards.

If there are duplicate files, the latest one is applied (i.e. the one in the highest numbered `resourcesXXX.s2z` takes precedence).

So if you wanted to apply a mod from scratch, you could create a mod and name it to the next number (e.g. `resources6.s2z` and, then `resources7.s2z` and so on).

Inside this zip-folder, you would place all of the modfified files that were edited in the same relative folder path as the original `resourcesXXX.s2z` file.

When the game engine loads this resource file, it will overwrite any existing files with matching names/paths.

### How HoN Mod Manager works

The HoN mod manager provides two functionalities:

1. It uses XML formatting to outline which file(s) need to be added, removed, or modified. This is done in the `mod.xml` file.

2. The mod manager will make copies of each file that it needs to modify and will apply all the modifications from `mod.xml`. Then it will bundle all of these files in `resources999.s2z`. The `999` is arbitrarily chosen to ensure it is effectively always applied last.