// set up local versions of the pipeline stages
// using partial application to bake in the dependencies
let validateOrder unvalidatedOrder = ...
let priceOrder validatedOrder = ...
let addShippingInfo pricedOrder = ...

// compose the pipeline from the new one-parameter functions
unvalidatedOrder
|> validateOrder
|> priceOrder
|> addShippingInfo
|> freeVipShipping
...