do $$

BEGIN

	IF EXISTS (SELECT schema_name FROM information_schema.schemata WHERE schema_name = 'cccat16' ) THEN 
		DROP SCHEMA cccat16 CASCADE;
	END IF;

	CREATE SCHEMA cccat16;

	create table cccat16.account (
		account_id serial primary key,
		name text not null,
		email text not null,
		cpf text not null,
		car_plate text null,
		is_passenger boolean not null default false,
		is_driver boolean not null default false
	);

END

$$

