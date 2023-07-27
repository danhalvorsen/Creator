test('Calling handler with valid command', () => {
    console.log("Test");
});
//Create htmlElement
function createHtmlElement(tagName, className) {
    document.body.innerHTML = `
    <span data-testid="not-empty"><span data-testid="empty"></span></span>
    <div data-testid="visible">Visible Example</div>
  `;
    const element = document.createElement(tagName);
    element.className = className;
    return element;
}
//# sourceMappingURL=AddWenElementhandler.test.js.map