/****** Object:  Table [dbo].[PupilInformation]    Script Date: 16-04-2022 19:31:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RiskFactors](
	[UniqueId] [int] IDENTITY(1,1) NOT NULL,
	[PupilUniqueId] [int] NOT NULL,
	[Cognitive strength 1] [nvarchar](max) NULL,
	[Cognitive strength 2] [nvarchar](max) NULL,
	[Cognitive strength 3] [nvarchar](max) NULL,
	[Cognitive strenght 4] [nvarchar](max) NULL,
	[Cognitive weakness 1] [nvarchar](max) NULL,
	[Cognitive weakness 2] [nvarchar](max) NULL,
	[Cognitive weakness 3] [nvarchar](max) NULL,
	[Cognitive weakness 4] [nvarchar](max) NULL,
	[Positive learning attitude 1] [nvarchar](max) NULL,
	[Positive learning attitude 2] [nvarchar](max) NULL,
	[Negative learning attitude 1] [nvarchar](max) NULL,
	[Negative learning attitude 2] [nvarchar](max) NULL,
	[Social strength 1] [nvarchar](max) NULL,
	[Socia strenght 2] [nvarchar](max) NULL,
	[Social weakness 1] [nvarchar](max) NULL,
	[Social weakness 2] [nvarchar](max) NULL,
	[Communicatie strength 1] [nvarchar](max) NULL,
	[Communicatie strength 2] [nvarchar](max) NULL,
	[Communicative weakness 1] [nvarchar](max) NULL,
	[Communicative weakness 2] [nvarchar](max) NULL,
	[Behavioral strengths 1] [nvarchar](max) NULL,
	[Behavioral strength 2] [nvarchar](max) NULL,
	[Behavioral strengths 3] [nvarchar](max) NULL,
	[Behavioral weakness 1] [nvarchar](max) NULL,
	[Behaviora weakness 2] [nvarchar](max) NULL,
	[Behavioral weakness 3] [nvarchar](max) NULL,
	[Emotional strength 1] [nvarchar](max) NULL,
	[Emotional strength 2] [nvarchar](max) NULL,
	[Emotional strength 3] [nvarchar](max) NULL,
	[Emotional weakness 1] [nvarchar](max) NULL,
	[Emotional weakness 2] [nvarchar](max) NULL,
	[Emotional weakness 3] [nvarchar](max) NULL,
	[Moral strength 1] [nvarchar](max) NULL,
	[Moral strength 2] [nvarchar](max) NULL,
	[Moral risk factor 1] [nvarchar](max) NULL,
	[Moral risk factor 2] [nvarchar](max) NULL,
	[Motor or sportive strength 1] [nvarchar](max) NULL,
	[Mottor or sportive strength 2] [nvarchar](max) NULL,
	[Motor or sportive weakness 1] [nvarchar](max) NULL,
	[Motor or sportive weakness 2] [nvarchar](max) NULL,
	[CREATIVE or ART STRENGTHS] [nvarchar](max) NULL,
	[CREATIVE or ART WEAKNESSES] [nvarchar](max) NULL,
	[LEISURE ACTVITIY PRESENT] [nvarchar](max) NULL,
	[LEISURE ACTIVITY NOT PRESENT] [nvarchar](max) NULL,
	[DAILY STRUCTURE PRESENT] [nvarchar](max) NULL,
	[DAILY STRUCTURE NOT PRESENT] [nvarchar](max) NULL,
	[PROTECTIVE FAMILY FACTORS] [nvarchar](max) NULL,
	[RISK FAMILY FACTORS] [nvarchar](max) NULL,
	[Integrative summary of the pupil] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[UniqueId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


