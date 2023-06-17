import { Icon, Item, Segment, Image, Button, Label } from "semantic-ui-react";

function CabinsListItem(){
    return(
        <Segment.Group className="centered">
            <Segment>
               <Item>
                    <Item.Header centered className="cabinItem centered"  >
                    Cabin Name <br></br>
                            <Icon name="star" />
                            <Icon name="star" />
                            <Icon name="star" />
                            <Icon name="star" />
                            <Icon name="star half" />
                    </Item.Header>                               
                </Item>
            </Segment>
            <Segment>
               <Image.Group  size="large">
                    <Image centered src='/assets/cabins/picts/1beds.jpg' />
                    <Image src='/assets/cabins/picts/1beds_2.jpg' />
                    <Image size="medium" src='/assets/cabins/picts/1beds_3.jpg' />
               </Image.Group>        
            </Segment>

            <Segment.Group className="centered" horizontal>
                <Segment className="centered" >
                  
                    <Label content="Price" >
                    <Icon name="dollar sign" /> PRICE 
                    </Label>
                    <Label content="Price" >
                    <Icon name="user" /> NB Persons 
                    </Label>
                    <Label content="Price" >
                    <Icon name="bed" /> NB Beds 
                    </Label>
                  
                </Segment>

                <Segment clearing>
                    <Button
                        floated="right"
                        content="Booking"
                        color="blue"
                    />
                </Segment>
            </Segment.Group>
           
        </Segment.Group>
    );
}

export default CabinsListItem