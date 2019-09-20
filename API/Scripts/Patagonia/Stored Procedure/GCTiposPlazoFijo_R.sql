ALTER procedure dbo.GCTiposPlazoFijo_R (@filtro varchar(100)=null, @isGrid varchar(30)=null)

as begin
	if (@filtro is null)
		set @filtro = ''
	if (@isGrid = '##GRID_OPTION##')
		begin
			select 
				ID 'ID',
				Alias 'Alias',
				Descripcion 'Descripcion',
				FechaAlta ,
				UsuarioAlta ,
				FechaEstado,
				UsuarioEstado
			from	
				GCTiposPlazoFijo			
			where
				(alias like '%' + ltrim(rtrim(@filtro)) + '%' 
			or  descripcion like '%' + ltrim(rtrim(@filtro)) + '%' 
			) and estado = 1
			order by
				alias asc
		end

	else
		begin /* COMBO */
			select 
				ID,
				ltrim(rtrim(Alias)) + ' - ' + ltrim(rtrim(Descripcion)) as 'Descripcion'
			from	
				GCTiposPlazoFijo			
			where
				(alias like '%' + ltrim(rtrim(@filtro)) + '%' 
			or  descripcion like '%' + ltrim(rtrim(@filtro)) + '%' 
			) and estado = 1
			order by
				Alias asc
		end					

end