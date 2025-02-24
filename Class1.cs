using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_02_cris_palomar
{
    abstract public class Funcionario
    {
		protected double salario;
		//protected String nome;
		//protected String cpf;

		public double Salario { get => salario; set => salario = value; }
		public virtual double getBonificacao()
		{
			/*get {*/ return this.salario * 0.10; //}
			//set { salario = value; }
		}

	}
    public class Gerente:Funcionario
    {
		protected int senha;
		public override double getBonificacao()
		{
        return this.salario * 0.15;
		}
	}
}