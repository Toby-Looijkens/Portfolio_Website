describe('My First Test', () => {
  it('finds the content "type"', () => {
    cy.visit('http://localhost:5173/')

    cy.get('[id=gallery]').click()

    // Should be on a new URL which
    // includes '/commands/actions'
    cy.url().should('include', '/Gallery')
    cy.get('h1').should('contain', 'test')
  })
})
