//importação do react
import {Component}  from 'react';

//criação da classe livros
class Livros extends Component{
    //criação da props
    constructor(props) {
        //definição da props
        super(props);
        //estados/valores da props
        this.state = {
            listaTiposLivros : [],
            titulo : '',
            idAutor: '',
            idInstituicao : '',
            dataPublicacao : new Date()
        }
    }

    //inicia  a função de buscar livros
    buscarLivros = () =>{
        //aparece mensagem no console
        console.log('chamando API')

        //passa o caminho da api
        fetch('http://localhost:5000/api/livros', {
            headers: {
                'Authorization' : 'Bearer' + localStorage.getItem('livro ')
            }
        })
    }

    //iniciação de funções
    componentDidMount(){
        //faz a chamada para a função de buscar livros
        this.buscarLivros();
    }

    //mostra o que vai ser renderizado na tela
    render(){
        return (
            <div>
                <main>
                    <section>
                        {/* lista dos livros */}
                        <h2>Lista dos livros</h2>
                        <table>
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Titulo</th>
                                    <th>Nome Autor</th>
                                    <th>Categoria</th>
                                    <th>Data Publicação</th>
                                </tr>
                            </thead>

                            {/*renderização de lista com suas propriedades*/}
                            <tbody>
                               {
                                   this.state.listaTiposLivros.map( (tipoLivro) => {
                                       return(
                                           <tr key={tipoLivro.idLivro}>
                                               <td>{tipoLivro.idLivro}</td>
                                               <td>{tipoLivro.Titulo}</td>
                                               <td>{tipoLivro.NomeAutor}</td>
                                               <td>{tipoLivro.Categoria}</td>
                                               <td>{tipoLivro.DataPublicacao}</td>
                                           </tr>
                                       )
                                   })
                               }
                            </tbody>
                        </table>
                    </section>
                </main>
            </div>
        )
    }
}

//exportação da classe, para uso em outras seções
export default Livros;