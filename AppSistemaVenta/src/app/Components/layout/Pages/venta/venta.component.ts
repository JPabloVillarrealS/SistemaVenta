import { Component, OnInit } from '@angular/core';

import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatTableDataSource } from '@angular/material/table';

import { ProductoService } from '../../../../Services/producto.service';
import { VentaService } from '../../../../Services/venta.service';
import { UtilidadService } from '../../../../Reutilizable/utilidad.service';

import { Producto } from '../../../../Interfaces/producto';
import { Venta } from '../../../../Interfaces/venta';
import { DetalleVenta } from '../../../../Interfaces/detalle-venta';

import Swal from 'sweetalert2';


@Component({
  selector: 'app-venta',
  templateUrl: './venta.component.html',
  styleUrl: './venta.component.css'
})
export class VentaComponent implements OnInit{

  listaProductos:Producto[]=[]; //crear variable listaProductos de tipo Producto pero en Array [] por defecto va estar vacio = [] 
  listaProductosFiltro: Producto []=[];

  listaProductosParaVenta:DetalleVenta[]=[];
  bloquearBotonRegistrar:boolean = false;

  constructor(){}

  ngOnInit(): void {
    
  }

}
