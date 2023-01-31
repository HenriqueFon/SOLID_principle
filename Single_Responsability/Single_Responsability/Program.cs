// See https://aka.ms/new-console-template for more information
using Single_Responsability;

/*  Cada classe deve ter sua própria e única função ex:
      
     class Order em que uma classe possui 3 funções diferentes: Manipulação de orders
     exibição de dados e carregamento, armazenamento de dados.
{
    public function calculateTotalSum(){}
    public function getItems() {}
    public function getItemCount() {}
    public function addItem($item) {}
    public function deleteItem($item) {}

    public function printOrder() {}
    public function showOrder() {}

    public function load() {}
    public function save() {}
    public function update() {}
    public function delete() {}
}

  ex:
    class Order desacoplado de maneira correta, cada classe possui sua única função
{
    public function calculateTotalSum(){}
    public function getItems() {}
    public function getItemCount() {}
    public function addItem($item) {}
    public function deleteItem($item) {}
    }

    class OrderRepository
    {
        public function load($orderID) {}
        public function save($order) {}
        public function update($order) {}
        public function delete($order) {}
    }

    class OrderViewer
    {
        public function printOrder($order) {}
        public function showOrder($order) {}
    }

    O princípio da responsabilidade única não se limita somente a classes, 
    ele também pode ser aplicado em métodos e funções, ou seja, 
    tudo que é responsável por executar uma ação, 
    deve ser responsável por apenas aquilo que se propõe a fazer.

*/

StandardMessage.WelcomeMessage();

Person user = PersonDataCapture.CaptureInformation();

bool isUserValid = PersonValidator.Validate(user);

if(!isUserValid)
{
    StandardMessage.EndApplication();
    return;
}

AccountGenerator.CreateAccount(user);

StandardMessage.EndApplication();