﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace Aerolina.Test.Application.Dto
{
    public class TripulacionDto_Test
    {

        [Fact]
        public void PedidoDto_CheckPropertiesValid()
        {
            var idTest = Guid.NewGuid();
            var nroPedidoTest = "ABC";
            var totalTest = 140;
            var detallePedidoTest = getDetallePedido();

            var objPedido = new PedidoDto();

            Assert.Equal(Guid.Empty, objPedido.Id);
            Assert.Null(objPedido.NroPedido);
            Assert.Equal(0, objPedido.Total);
            Assert.Empty(objPedido.Detalle);

            objPedido.Id = idTest;
            objPedido.NroPedido = nroPedidoTest;
            objPedido.Total = totalTest;
            objPedido.Detalle = detallePedidoTest;

            Assert.Equal(idTest, objPedido.Id);
            Assert.Equal(nroPedidoTest, objPedido.NroPedido);
            Assert.Equal(totalTest, objPedido.Total);
            Assert.Equal(detallePedidoTest.Count, objPedido.Detalle.Count);
        }
    }
}
