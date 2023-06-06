import { ImageList,ImageListItem } from '@mui/material'
import React from 'react'
import { Card, Container, Grid, GridColumn, Image } from 'semantic-ui-react'
const imageList =[
    {
        img:'/assets/picts/4.jpg',
        cols:1,
        rows:2,
        title:"img 1",
    },
    {
        img:'/assets/picts/3.jpg',
        cols:2,
        rows:2,
        title:"img 1",
    },
    {
        img:'/assets/picts/2.jpg',
        cols:2,
        rows:2,
        title:"img 1",
    },
    {
        img:'/assets/picts/1.jpg',
        cols:1,
        rows:2,
        title:"img 1",
    },
    {
        img:'/assets/picts/left.jpg',
        cols:1,
        rows:1,
        title:"img 1",
    }
]
// const src1 = '/assets/picts/1.jpg'
// const src2 = '/assets/picts/2.jpg'
// const src3 = '/assets/picts/3.jpg'
// const src4 = '/assets/picts/4.jpg'
// const srcLeft = '/assets/picts/left.jpg'
function srcset(image: string, size: number, rows = 1, cols = 1) {
    return {
      src: `${image}?w=${size * cols}&h=${size * rows}&fit=crop&auto=format`,
      srcSet: `${image}?w=${size * cols}&h=${
        size * rows
      }&fit=crop&auto=format&dpr=2 2x`,
    };
  }
const ImageHeader = () => {
    return(
        
            <ImageList
                sx={{ width: 1800, height: 450 }}
                variant="quilted"
                cols={6}
                rowHeight={121}                
            >
            {imageList.map((item) => (
                <ImageListItem key={item.img} cols={item.cols || 1} rows={item.rows || 1}>
                    <img
                        {...srcset(item.img, 121, item.rows, item.cols)}
                        alt={item.title}
                        loading="lazy"
                    />
                </ImageListItem>
            ))}
            </ImageList>
       
    );
}
export default ImageHeader;
// const ImageHeader = () => {
//     return (
//             <Container style={{marginTop:'7em', padding:'5px'}} >
//             <Grid height={6} >
//                 <Grid.Column  width={4}  >
//                     <Card.Group itemsPerRow={1}>
//                         <Card color='grey' image={srcLeft} />
//                     </Card.Group>
//                 </Grid.Column>
//                 <Grid.Column  width={12}  >
//                     <Card.Group itemsPerRow={2}>
//                     <Card color='grey'>
//                           <Image  src={src1} size='medium'/>
//                     </Card>
//                     <Card color='grey'>
//                           <Image  src={src2} size='medium'/>
//                     </Card>
//                     <Card color='grey'>
//                           <Image  src={src3} size='medium'/>
//                     </Card>
//                     <Card color='grey'>
//                           <Image  src={src4} size='medium'/>
//                     </Card>
                      
                        
//                     </Card.Group>
//                 </Grid.Column>
//             </Grid>
//         </Container>
//     );
// }

// export default ImageHeader