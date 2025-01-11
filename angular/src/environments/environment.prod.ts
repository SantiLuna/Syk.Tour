import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4300';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Tour',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44379/',
    redirectUri: baseUrl,
    clientId: 'Tour_App',
    responseType: 'code',
    scope: 'offline_access Tour',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44379',
      rootNamespace: 'Syk.Tour',
    },
  },
} as Environment;
