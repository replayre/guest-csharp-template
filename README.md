# guest-csharp-template
A generic UGC bundle template for replay.re

## Nuget dependencies

### Installing nuget dependencies
```sh
dotnet restore --verbosity normal
```

### Updating dependencies
Dependencies are pinned with a floating version
To update to a more recent build use the following commands

```sh
dotnet restore --force-evaluate
```

or

```sh
dotnet nuget locals all -c
dotnet restore
```

## Building
- `dotnet build` or `dotnet build -c Release`

## Deploying
We recommend symlinking your dist/ folder into the data/ugc/ folder
of your server

`ln -s /opt/replay/guest-csharp-template/dist /opt/replay/server/data/ugc/example`

You can then start the bundle via

`start example`