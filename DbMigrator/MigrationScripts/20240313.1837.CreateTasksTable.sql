create table if not exists Tasks (
    TA_Id integer primary key AUTOINCREMENT,
    TA_Title text not null,
    TA_PlannedTime integer not null default 0,
    TA_Closed numeric not null default 0,
    TA_RelProjectId integer not null references Projects(PR_Id),
    TA_SourceType integer not null,
    TA_SourceTaskId text not null
)