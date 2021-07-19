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
            titulo : ''
        }
    }

    //iniciação de funções
    componentDidMount(){

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
                                    <th>Autor</th>
                                </tr>
                            </thead>
                        </table>
                    </section>
                </main>
            </div>
        )
    }
}

//exportação da classe, para uso em outras seções
export default Livros;