# Mini-CRM
Tool example created during my session at Scottish Summit 2022

## Demo Script

[sorry, very raw, maybe what I did, maybe not]

```
--  1  --
Create new project
Run
Fix debug
Run
Add connections
 
--  2  --
Create repo in Git
Remove buttons
Remove methods
Add Rappen projects
Add References
 
--  3  --
Add XRMEntityComboBox
Normal ComboBox
Added event ConnectionUpdated
GetEntities();
 
--  4  --
GetEntities:
xrmEntity.DataSource = Service.LoadEntities().EntityMetadata;
Run
 
--  5  --
WorkAsync
Message, Work, Post…
Error handling
Check result type
Run
 
--  6  --
Add CheckBox: Managed (Intersect)
Event GetEntities()
Add checking IsManaged
Run

--  7  --
OnEvent Entity
GetViews();
Copy from GetEntites
Get current Entity
Change things
 
--  8  --
We need to get Views
Run FXB to get it
Copy QueryExpression pre WorkAsync
Add XRMColumnLookup
Set Service
Set DataSource - simple!
 
--  9  --
Add XRMDataGridView, fill
Set Service
GetData() 
Get FetchXML
Copy from GetViews
Set DataSource - simple!
 
--  10  --
Add XRMRecordHost
Set Service
OnRecordClick set Record
Add XRMColumnText
Set Column.RecordHost
GetViews set Column

--  11  --
Add button Save
Call SaveChanges

```
