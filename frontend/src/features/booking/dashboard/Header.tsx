import React from 'react'
import { Header, Icon, Image } from 'semantic-ui-react'

const HeaderLogoIcon = () => (
  <div>
    <Header style={{margin: '30px'}} as='h2' icon textAlign='center'>
      <Icon name='users' circular />
      <Header.Content>Los Cielos</Header.Content>
    </Header>
    {/* <Image
      centered
      size='large'
      src='/images/wireframe/centered-paragraph.png'
    /> */}
  </div>
)

export default HeaderLogoIcon