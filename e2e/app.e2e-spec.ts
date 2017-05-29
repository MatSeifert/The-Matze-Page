import { MatzeHomepageAppPage } from './app.po';

describe('matze-homepage-app App', () => {
  let page: MatzeHomepageAppPage;

  beforeEach(() => {
    page = new MatzeHomepageAppPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
