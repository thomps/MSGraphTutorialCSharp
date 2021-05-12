const msalConfig = {
    auth: {
      clientId: '65a7ec07-1a46-4b79-ba78-150e555c1765',
      authority: 'https://login.microsoftonline.com/cae7a454-c077-4cbb-8392-610cebcb2c05'
    }
  };
  
  const msalRequest = {
    // Scope of the Azure Function
    scopes: [
      '7c966608-bcf6-431b-ba36-01c724904ad0/.default'
    ]
  }