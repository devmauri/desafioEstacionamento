using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento
{
    /// <summary>
    /// Interface para padronização dos cruds.
    /// </summary>
    /// <typeparam name="T">Classe a ser feito crud</typeparam>
    public interface iCRUD<T>
    {
        /// <summary>
        /// Método a ser implementado por classe concreta em que adicionará um novo item.
        /// </summary>
        /// <param name="item">Item a ser acidionado.</param>
        /// <returns>Verdadeiro se adicionado, falso se contiver algum erro.</returns>
        public Boolean Adicionar(T item);
        /// <summary>
        /// Método a ser implementado por classe concreta em que listará todos os itens adicionados.
        /// </summary>
        /// <returns>Lista com todos os itens adicionados.</returns>
        public List<T> Listar();
        /// <summary>
        /// Método a ser implementado por classe concreta que irá retornar apenas um item especifico.
        /// </summary>
        /// <param name="id">Identificação do item a ser retornado.</param>
        /// <returns>Item solicitado. Null caso não encontre.</returns>
        public T Ler(String id);
        /// <summary>
        /// Método a ser implementado por classe concreta que irá tualizar um determinado item.
        /// </summary>
        /// <param name="item">Item atualizado (com exeção do id).</param>
        /// <returns>Verdadeiro se atualizado, falso se contiver algum erro.</returns>
        public Boolean Atualizar(T item);
        /// <summary>
        /// Método a ser implementado por classe concreta que irá remover um determinado item.
        /// </summary>
        /// <param name="item">Item a ser removido</param>
        /// <returns>Verdadeiro se removido ou se item não existir, falso se contiver algum erro.</returns>
        public Boolean Remover(T item);
    }
}