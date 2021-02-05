SELECT C.Id,
       B.BrandName,
       CL.ColorName,
       C.ModelYear,
       C.DailyPrice,
       C.Description
  FROM Cars C
  LEFT JOIN Brands B
    ON C.BrandId = B.Id
  LEFT JOIN Colors CL
    ON C.ColorId = CL.Id
