import logo from './logo.svg';
import './App.css';
import {store} from './actions/store'
import {Provider} from "react-redux"
import Categories from './components/Categories';
import {Container} from '@material-ui/core'
import SimpleTabs from './components/SimpleTab';
import {ToastProvider} from 'react-toast-notifications'
function App() {
  return (
    <Provider store={store}>
      <ToastProvider autoDismiss = {true}>
        <Container store={store} maxWidth = "lg">
          <SimpleTabs/>
        </Container>
        </ToastProvider>
    </Provider>
  );
}

export default App;
