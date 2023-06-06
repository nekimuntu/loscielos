import { IncomingMessage } from "http";
import React from "react";
import { Icon, ItemContent, Item, Segment, SegmentGroup, Image, Button, Label } from "semantic-ui-react";

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
               <Image.Group  size="small">
                    <Image centered src='/assets/picts/1.jpg' />
                    <Image src='/assets/picts/1.jpg' />
                    <Image src='/assets/picts/1.jpg' />
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