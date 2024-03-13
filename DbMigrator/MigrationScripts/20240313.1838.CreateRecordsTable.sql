create table if not exists Records (
	RE_Id integer primary key AUTOINCREMENT,
	RE_StartedAt datetime not null,
	RE_FinishedAt datetime null,
	RE_MinutesSpent integer not null default 0,
	RE_Comment text,
	RE_RelTaskId integer not null references "Tasks"(TA_Id)
)