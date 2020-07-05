import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = {
            connection: {}, loading: true, secretID: Math.floor(Math.random() * 10 ** 10) }
    }

    componentDidMount() {
        this.fetchConnection();
    }

    render () {
        return (
            <div>
                <h1>web IDE v0.0.0</h1>


                <>
                    {this.state.loading ? <h4>Connecting to server...</h4> :
                        <h4>your access code: {this.state.connection._accessCode}</h4>}
                    <textarea id="typingArea">
                        print
                    </textarea>
                </>

            </div>
        );
    }

    async fetchConnection() {
        console.log("started")
        const response = await fetch(`ide/newConnection/${this.state.secretID}`);
        console.log(response)
        const data = await response.json();
        console.log(data)
        this.setState({ connection: data, loading: false });
        console.log(this.state);
    }
}
