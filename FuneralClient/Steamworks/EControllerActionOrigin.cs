using System;

namespace Steamworks2
{
	// Token: 0x0200003E RID: 62
	public enum EControllerActionOrigin
	{
		// Token: 0x040001C0 RID: 448
		k_EControllerActionOrigin_None,
		// Token: 0x040001C1 RID: 449
		k_EControllerActionOrigin_A,
		// Token: 0x040001C2 RID: 450
		k_EControllerActionOrigin_B,
		// Token: 0x040001C3 RID: 451
		k_EControllerActionOrigin_X,
		// Token: 0x040001C4 RID: 452
		k_EControllerActionOrigin_Y,
		// Token: 0x040001C5 RID: 453
		k_EControllerActionOrigin_LeftBumper,
		// Token: 0x040001C6 RID: 454
		k_EControllerActionOrigin_RightBumper,
		// Token: 0x040001C7 RID: 455
		k_EControllerActionOrigin_LeftGrip,
		// Token: 0x040001C8 RID: 456
		k_EControllerActionOrigin_RightGrip,
		// Token: 0x040001C9 RID: 457
		k_EControllerActionOrigin_Start,
		// Token: 0x040001CA RID: 458
		k_EControllerActionOrigin_Back,
		// Token: 0x040001CB RID: 459
		k_EControllerActionOrigin_LeftPad_Touch,
		// Token: 0x040001CC RID: 460
		k_EControllerActionOrigin_LeftPad_Swipe,
		// Token: 0x040001CD RID: 461
		k_EControllerActionOrigin_LeftPad_Click,
		// Token: 0x040001CE RID: 462
		k_EControllerActionOrigin_LeftPad_DPadNorth,
		// Token: 0x040001CF RID: 463
		k_EControllerActionOrigin_LeftPad_DPadSouth,
		// Token: 0x040001D0 RID: 464
		k_EControllerActionOrigin_LeftPad_DPadWest,
		// Token: 0x040001D1 RID: 465
		k_EControllerActionOrigin_LeftPad_DPadEast,
		// Token: 0x040001D2 RID: 466
		k_EControllerActionOrigin_RightPad_Touch,
		// Token: 0x040001D3 RID: 467
		k_EControllerActionOrigin_RightPad_Swipe,
		// Token: 0x040001D4 RID: 468
		k_EControllerActionOrigin_RightPad_Click,
		// Token: 0x040001D5 RID: 469
		k_EControllerActionOrigin_RightPad_DPadNorth,
		// Token: 0x040001D6 RID: 470
		k_EControllerActionOrigin_RightPad_DPadSouth,
		// Token: 0x040001D7 RID: 471
		k_EControllerActionOrigin_RightPad_DPadWest,
		// Token: 0x040001D8 RID: 472
		k_EControllerActionOrigin_RightPad_DPadEast,
		// Token: 0x040001D9 RID: 473
		k_EControllerActionOrigin_LeftTrigger_Pull,
		// Token: 0x040001DA RID: 474
		k_EControllerActionOrigin_LeftTrigger_Click,
		// Token: 0x040001DB RID: 475
		k_EControllerActionOrigin_RightTrigger_Pull,
		// Token: 0x040001DC RID: 476
		k_EControllerActionOrigin_RightTrigger_Click,
		// Token: 0x040001DD RID: 477
		k_EControllerActionOrigin_LeftStick_Move,
		// Token: 0x040001DE RID: 478
		k_EControllerActionOrigin_LeftStick_Click,
		// Token: 0x040001DF RID: 479
		k_EControllerActionOrigin_LeftStick_DPadNorth,
		// Token: 0x040001E0 RID: 480
		k_EControllerActionOrigin_LeftStick_DPadSouth,
		// Token: 0x040001E1 RID: 481
		k_EControllerActionOrigin_LeftStick_DPadWest,
		// Token: 0x040001E2 RID: 482
		k_EControllerActionOrigin_LeftStick_DPadEast,
		// Token: 0x040001E3 RID: 483
		k_EControllerActionOrigin_Gyro_Move,
		// Token: 0x040001E4 RID: 484
		k_EControllerActionOrigin_Gyro_Pitch,
		// Token: 0x040001E5 RID: 485
		k_EControllerActionOrigin_Gyro_Yaw,
		// Token: 0x040001E6 RID: 486
		k_EControllerActionOrigin_Gyro_Roll,
		// Token: 0x040001E7 RID: 487
		k_EControllerActionOrigin_PS4_X,
		// Token: 0x040001E8 RID: 488
		k_EControllerActionOrigin_PS4_Circle,
		// Token: 0x040001E9 RID: 489
		k_EControllerActionOrigin_PS4_Triangle,
		// Token: 0x040001EA RID: 490
		k_EControllerActionOrigin_PS4_Square,
		// Token: 0x040001EB RID: 491
		k_EControllerActionOrigin_PS4_LeftBumper,
		// Token: 0x040001EC RID: 492
		k_EControllerActionOrigin_PS4_RightBumper,
		// Token: 0x040001ED RID: 493
		k_EControllerActionOrigin_PS4_Options,
		// Token: 0x040001EE RID: 494
		k_EControllerActionOrigin_PS4_Share,
		// Token: 0x040001EF RID: 495
		k_EControllerActionOrigin_PS4_LeftPad_Touch,
		// Token: 0x040001F0 RID: 496
		k_EControllerActionOrigin_PS4_LeftPad_Swipe,
		// Token: 0x040001F1 RID: 497
		k_EControllerActionOrigin_PS4_LeftPad_Click,
		// Token: 0x040001F2 RID: 498
		k_EControllerActionOrigin_PS4_LeftPad_DPadNorth,
		// Token: 0x040001F3 RID: 499
		k_EControllerActionOrigin_PS4_LeftPad_DPadSouth,
		// Token: 0x040001F4 RID: 500
		k_EControllerActionOrigin_PS4_LeftPad_DPadWest,
		// Token: 0x040001F5 RID: 501
		k_EControllerActionOrigin_PS4_LeftPad_DPadEast,
		// Token: 0x040001F6 RID: 502
		k_EControllerActionOrigin_PS4_RightPad_Touch,
		// Token: 0x040001F7 RID: 503
		k_EControllerActionOrigin_PS4_RightPad_Swipe,
		// Token: 0x040001F8 RID: 504
		k_EControllerActionOrigin_PS4_RightPad_Click,
		// Token: 0x040001F9 RID: 505
		k_EControllerActionOrigin_PS4_RightPad_DPadNorth,
		// Token: 0x040001FA RID: 506
		k_EControllerActionOrigin_PS4_RightPad_DPadSouth,
		// Token: 0x040001FB RID: 507
		k_EControllerActionOrigin_PS4_RightPad_DPadWest,
		// Token: 0x040001FC RID: 508
		k_EControllerActionOrigin_PS4_RightPad_DPadEast,
		// Token: 0x040001FD RID: 509
		k_EControllerActionOrigin_PS4_CenterPad_Touch,
		// Token: 0x040001FE RID: 510
		k_EControllerActionOrigin_PS4_CenterPad_Swipe,
		// Token: 0x040001FF RID: 511
		k_EControllerActionOrigin_PS4_CenterPad_Click,
		// Token: 0x04000200 RID: 512
		k_EControllerActionOrigin_PS4_CenterPad_DPadNorth,
		// Token: 0x04000201 RID: 513
		k_EControllerActionOrigin_PS4_CenterPad_DPadSouth,
		// Token: 0x04000202 RID: 514
		k_EControllerActionOrigin_PS4_CenterPad_DPadWest,
		// Token: 0x04000203 RID: 515
		k_EControllerActionOrigin_PS4_CenterPad_DPadEast,
		// Token: 0x04000204 RID: 516
		k_EControllerActionOrigin_PS4_LeftTrigger_Pull,
		// Token: 0x04000205 RID: 517
		k_EControllerActionOrigin_PS4_LeftTrigger_Click,
		// Token: 0x04000206 RID: 518
		k_EControllerActionOrigin_PS4_RightTrigger_Pull,
		// Token: 0x04000207 RID: 519
		k_EControllerActionOrigin_PS4_RightTrigger_Click,
		// Token: 0x04000208 RID: 520
		k_EControllerActionOrigin_PS4_LeftStick_Move,
		// Token: 0x04000209 RID: 521
		k_EControllerActionOrigin_PS4_LeftStick_Click,
		// Token: 0x0400020A RID: 522
		k_EControllerActionOrigin_PS4_LeftStick_DPadNorth,
		// Token: 0x0400020B RID: 523
		k_EControllerActionOrigin_PS4_LeftStick_DPadSouth,
		// Token: 0x0400020C RID: 524
		k_EControllerActionOrigin_PS4_LeftStick_DPadWest,
		// Token: 0x0400020D RID: 525
		k_EControllerActionOrigin_PS4_LeftStick_DPadEast,
		// Token: 0x0400020E RID: 526
		k_EControllerActionOrigin_PS4_RightStick_Move,
		// Token: 0x0400020F RID: 527
		k_EControllerActionOrigin_PS4_RightStick_Click,
		// Token: 0x04000210 RID: 528
		k_EControllerActionOrigin_PS4_RightStick_DPadNorth,
		// Token: 0x04000211 RID: 529
		k_EControllerActionOrigin_PS4_RightStick_DPadSouth,
		// Token: 0x04000212 RID: 530
		k_EControllerActionOrigin_PS4_RightStick_DPadWest,
		// Token: 0x04000213 RID: 531
		k_EControllerActionOrigin_PS4_RightStick_DPadEast,
		// Token: 0x04000214 RID: 532
		k_EControllerActionOrigin_PS4_DPad_North,
		// Token: 0x04000215 RID: 533
		k_EControllerActionOrigin_PS4_DPad_South,
		// Token: 0x04000216 RID: 534
		k_EControllerActionOrigin_PS4_DPad_West,
		// Token: 0x04000217 RID: 535
		k_EControllerActionOrigin_PS4_DPad_East,
		// Token: 0x04000218 RID: 536
		k_EControllerActionOrigin_PS4_Gyro_Move,
		// Token: 0x04000219 RID: 537
		k_EControllerActionOrigin_PS4_Gyro_Pitch,
		// Token: 0x0400021A RID: 538
		k_EControllerActionOrigin_PS4_Gyro_Yaw,
		// Token: 0x0400021B RID: 539
		k_EControllerActionOrigin_PS4_Gyro_Roll,
		// Token: 0x0400021C RID: 540
		k_EControllerActionOrigin_XBoxOne_A,
		// Token: 0x0400021D RID: 541
		k_EControllerActionOrigin_XBoxOne_B,
		// Token: 0x0400021E RID: 542
		k_EControllerActionOrigin_XBoxOne_X,
		// Token: 0x0400021F RID: 543
		k_EControllerActionOrigin_XBoxOne_Y,
		// Token: 0x04000220 RID: 544
		k_EControllerActionOrigin_XBoxOne_LeftBumper,
		// Token: 0x04000221 RID: 545
		k_EControllerActionOrigin_XBoxOne_RightBumper,
		// Token: 0x04000222 RID: 546
		k_EControllerActionOrigin_XBoxOne_Menu,
		// Token: 0x04000223 RID: 547
		k_EControllerActionOrigin_XBoxOne_View,
		// Token: 0x04000224 RID: 548
		k_EControllerActionOrigin_XBoxOne_LeftTrigger_Pull,
		// Token: 0x04000225 RID: 549
		k_EControllerActionOrigin_XBoxOne_LeftTrigger_Click,
		// Token: 0x04000226 RID: 550
		k_EControllerActionOrigin_XBoxOne_RightTrigger_Pull,
		// Token: 0x04000227 RID: 551
		k_EControllerActionOrigin_XBoxOne_RightTrigger_Click,
		// Token: 0x04000228 RID: 552
		k_EControllerActionOrigin_XBoxOne_LeftStick_Move,
		// Token: 0x04000229 RID: 553
		k_EControllerActionOrigin_XBoxOne_LeftStick_Click,
		// Token: 0x0400022A RID: 554
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadNorth,
		// Token: 0x0400022B RID: 555
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadSouth,
		// Token: 0x0400022C RID: 556
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadWest,
		// Token: 0x0400022D RID: 557
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadEast,
		// Token: 0x0400022E RID: 558
		k_EControllerActionOrigin_XBoxOne_RightStick_Move,
		// Token: 0x0400022F RID: 559
		k_EControllerActionOrigin_XBoxOne_RightStick_Click,
		// Token: 0x04000230 RID: 560
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadNorth,
		// Token: 0x04000231 RID: 561
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadSouth,
		// Token: 0x04000232 RID: 562
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadWest,
		// Token: 0x04000233 RID: 563
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadEast,
		// Token: 0x04000234 RID: 564
		k_EControllerActionOrigin_XBoxOne_DPad_North,
		// Token: 0x04000235 RID: 565
		k_EControllerActionOrigin_XBoxOne_DPad_South,
		// Token: 0x04000236 RID: 566
		k_EControllerActionOrigin_XBoxOne_DPad_West,
		// Token: 0x04000237 RID: 567
		k_EControllerActionOrigin_XBoxOne_DPad_East,
		// Token: 0x04000238 RID: 568
		k_EControllerActionOrigin_XBox360_A,
		// Token: 0x04000239 RID: 569
		k_EControllerActionOrigin_XBox360_B,
		// Token: 0x0400023A RID: 570
		k_EControllerActionOrigin_XBox360_X,
		// Token: 0x0400023B RID: 571
		k_EControllerActionOrigin_XBox360_Y,
		// Token: 0x0400023C RID: 572
		k_EControllerActionOrigin_XBox360_LeftBumper,
		// Token: 0x0400023D RID: 573
		k_EControllerActionOrigin_XBox360_RightBumper,
		// Token: 0x0400023E RID: 574
		k_EControllerActionOrigin_XBox360_Start,
		// Token: 0x0400023F RID: 575
		k_EControllerActionOrigin_XBox360_Back,
		// Token: 0x04000240 RID: 576
		k_EControllerActionOrigin_XBox360_LeftTrigger_Pull,
		// Token: 0x04000241 RID: 577
		k_EControllerActionOrigin_XBox360_LeftTrigger_Click,
		// Token: 0x04000242 RID: 578
		k_EControllerActionOrigin_XBox360_RightTrigger_Pull,
		// Token: 0x04000243 RID: 579
		k_EControllerActionOrigin_XBox360_RightTrigger_Click,
		// Token: 0x04000244 RID: 580
		k_EControllerActionOrigin_XBox360_LeftStick_Move,
		// Token: 0x04000245 RID: 581
		k_EControllerActionOrigin_XBox360_LeftStick_Click,
		// Token: 0x04000246 RID: 582
		k_EControllerActionOrigin_XBox360_LeftStick_DPadNorth,
		// Token: 0x04000247 RID: 583
		k_EControllerActionOrigin_XBox360_LeftStick_DPadSouth,
		// Token: 0x04000248 RID: 584
		k_EControllerActionOrigin_XBox360_LeftStick_DPadWest,
		// Token: 0x04000249 RID: 585
		k_EControllerActionOrigin_XBox360_LeftStick_DPadEast,
		// Token: 0x0400024A RID: 586
		k_EControllerActionOrigin_XBox360_RightStick_Move,
		// Token: 0x0400024B RID: 587
		k_EControllerActionOrigin_XBox360_RightStick_Click,
		// Token: 0x0400024C RID: 588
		k_EControllerActionOrigin_XBox360_RightStick_DPadNorth,
		// Token: 0x0400024D RID: 589
		k_EControllerActionOrigin_XBox360_RightStick_DPadSouth,
		// Token: 0x0400024E RID: 590
		k_EControllerActionOrigin_XBox360_RightStick_DPadWest,
		// Token: 0x0400024F RID: 591
		k_EControllerActionOrigin_XBox360_RightStick_DPadEast,
		// Token: 0x04000250 RID: 592
		k_EControllerActionOrigin_XBox360_DPad_North,
		// Token: 0x04000251 RID: 593
		k_EControllerActionOrigin_XBox360_DPad_South,
		// Token: 0x04000252 RID: 594
		k_EControllerActionOrigin_XBox360_DPad_West,
		// Token: 0x04000253 RID: 595
		k_EControllerActionOrigin_XBox360_DPad_East,
		// Token: 0x04000254 RID: 596
		k_EControllerActionOrigin_SteamV2_A,
		// Token: 0x04000255 RID: 597
		k_EControllerActionOrigin_SteamV2_B,
		// Token: 0x04000256 RID: 598
		k_EControllerActionOrigin_SteamV2_X,
		// Token: 0x04000257 RID: 599
		k_EControllerActionOrigin_SteamV2_Y,
		// Token: 0x04000258 RID: 600
		k_EControllerActionOrigin_SteamV2_LeftBumper,
		// Token: 0x04000259 RID: 601
		k_EControllerActionOrigin_SteamV2_RightBumper,
		// Token: 0x0400025A RID: 602
		k_EControllerActionOrigin_SteamV2_LeftGrip,
		// Token: 0x0400025B RID: 603
		k_EControllerActionOrigin_SteamV2_RightGrip,
		// Token: 0x0400025C RID: 604
		k_EControllerActionOrigin_SteamV2_LeftGrip_Upper,
		// Token: 0x0400025D RID: 605
		k_EControllerActionOrigin_SteamV2_RightGrip_Upper,
		// Token: 0x0400025E RID: 606
		k_EControllerActionOrigin_SteamV2_LeftBumper_Pressure,
		// Token: 0x0400025F RID: 607
		k_EControllerActionOrigin_SteamV2_RightBumper_Pressure,
		// Token: 0x04000260 RID: 608
		k_EControllerActionOrigin_SteamV2_LeftGrip_Pressure,
		// Token: 0x04000261 RID: 609
		k_EControllerActionOrigin_SteamV2_RightGrip_Pressure,
		// Token: 0x04000262 RID: 610
		k_EControllerActionOrigin_SteamV2_LeftGrip_Upper_Pressure,
		// Token: 0x04000263 RID: 611
		k_EControllerActionOrigin_SteamV2_RightGrip_Upper_Pressure,
		// Token: 0x04000264 RID: 612
		k_EControllerActionOrigin_SteamV2_Start,
		// Token: 0x04000265 RID: 613
		k_EControllerActionOrigin_SteamV2_Back,
		// Token: 0x04000266 RID: 614
		k_EControllerActionOrigin_SteamV2_LeftPad_Touch,
		// Token: 0x04000267 RID: 615
		k_EControllerActionOrigin_SteamV2_LeftPad_Swipe,
		// Token: 0x04000268 RID: 616
		k_EControllerActionOrigin_SteamV2_LeftPad_Click,
		// Token: 0x04000269 RID: 617
		k_EControllerActionOrigin_SteamV2_LeftPad_Pressure,
		// Token: 0x0400026A RID: 618
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadNorth,
		// Token: 0x0400026B RID: 619
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadSouth,
		// Token: 0x0400026C RID: 620
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadWest,
		// Token: 0x0400026D RID: 621
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadEast,
		// Token: 0x0400026E RID: 622
		k_EControllerActionOrigin_SteamV2_RightPad_Touch,
		// Token: 0x0400026F RID: 623
		k_EControllerActionOrigin_SteamV2_RightPad_Swipe,
		// Token: 0x04000270 RID: 624
		k_EControllerActionOrigin_SteamV2_RightPad_Click,
		// Token: 0x04000271 RID: 625
		k_EControllerActionOrigin_SteamV2_RightPad_Pressure,
		// Token: 0x04000272 RID: 626
		k_EControllerActionOrigin_SteamV2_RightPad_DPadNorth,
		// Token: 0x04000273 RID: 627
		k_EControllerActionOrigin_SteamV2_RightPad_DPadSouth,
		// Token: 0x04000274 RID: 628
		k_EControllerActionOrigin_SteamV2_RightPad_DPadWest,
		// Token: 0x04000275 RID: 629
		k_EControllerActionOrigin_SteamV2_RightPad_DPadEast,
		// Token: 0x04000276 RID: 630
		k_EControllerActionOrigin_SteamV2_LeftTrigger_Pull,
		// Token: 0x04000277 RID: 631
		k_EControllerActionOrigin_SteamV2_LeftTrigger_Click,
		// Token: 0x04000278 RID: 632
		k_EControllerActionOrigin_SteamV2_RightTrigger_Pull,
		// Token: 0x04000279 RID: 633
		k_EControllerActionOrigin_SteamV2_RightTrigger_Click,
		// Token: 0x0400027A RID: 634
		k_EControllerActionOrigin_SteamV2_LeftStick_Move,
		// Token: 0x0400027B RID: 635
		k_EControllerActionOrigin_SteamV2_LeftStick_Click,
		// Token: 0x0400027C RID: 636
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadNorth,
		// Token: 0x0400027D RID: 637
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadSouth,
		// Token: 0x0400027E RID: 638
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadWest,
		// Token: 0x0400027F RID: 639
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadEast,
		// Token: 0x04000280 RID: 640
		k_EControllerActionOrigin_SteamV2_Gyro_Move,
		// Token: 0x04000281 RID: 641
		k_EControllerActionOrigin_SteamV2_Gyro_Pitch,
		// Token: 0x04000282 RID: 642
		k_EControllerActionOrigin_SteamV2_Gyro_Yaw,
		// Token: 0x04000283 RID: 643
		k_EControllerActionOrigin_SteamV2_Gyro_Roll,
		// Token: 0x04000284 RID: 644
		k_EControllerActionOrigin_Count
	}
}
