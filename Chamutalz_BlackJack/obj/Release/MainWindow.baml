   M S B A M L   `   `   `  ���� N  JChamutalz_BlackJack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Chamutalz_BlackJackChamutalz_BlackJack  $    Chamutalz_BlackJack.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:Chamutalz_BlackJack       � Title$  Chamutalz_BlackJack��$	��720��$
��1200�� � 	Resources    
ButtonGrey��%   &	        ��	#FFCDCDCD��.��� .+��� -    ��Name$( "background_chamutalz_blackjack_png��$��
-8,-30,0,0q�$(��"background chamutalz blackjack.png��$
��Fill=��� -    ��Name$ dealerScore��$
��Left=�$��85��$��
80,102,0,0q�$
��Wrap=�$��Dealer's Score��$	��Top=�$	��350��$��48(�$��Viner Hand ITC)�$
��Bold"��� -   $ myScore��$
��Left=�$��84��$��
80,372,0,0q�$
��Wrap=�$��My Score��$	��Top=�$	��265��$��48(�$
��Bold"�$��Viner Hand ITC)��� -    ��Name$ newGame��$��New Game��$
��Left=�$��55��$��
80,605,0,0q�$	��Top=�$	��170��$��26.667(�$��Viner Hand ITC)����	#FF7E2121 J� RenderTransformOrigin$ 
9.35,2.883&� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 10Q��� -   $
 pass��$��I'll take my chances��$
��Left=�$��55��$��288,605,0,0q�$	��Top=�$	��305�����	#FF7E2121$��26.667(�$��Viner Hand ITC)�   $ 10Q��� -   $ drawOneMore��$��More blood!��$
��Left=�$��55��$��627,605,0,0q�$	��Top=�$	��190�����	#FF7E2121$��Viner Hand ITC)�$��26.667(�����  �� EndPoint$	 0,1&�	 �� 
StartPoint$		 0,0&�.��� 
 � Color$
 	#FFF3F3F3�� � Offset$ 0Q�� $
 	#FFEBEBEB��$	 0.5Q�� $
 	#FFDDDDDD��$	 0.5Q�� $
 	#FFCDCDCD��$ 1Q�   $ 10Q��� -    ��Name$ dealerScoreInt��$
��Left=�$��80��$��
80,229,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��153��$��48(�$��Viner Hand ITC)�{�.  �� -   $ playerScore��$
��Left=�$��80��$��
80,484,0,0q�$
 Wrap=�$	��Top=�$	��153��$��48(�$��Viner Hand ITC)�{�.  �� -	   $ card1d��$	��224��$	��Top=�$��447,85,599,0q��� -
   $ card2d��$	��224��$	��Top=�$��669,85,375,0q��� -   $ card3d��$	��224��$	��Top=�$��891,85,156,0q��� -   $ card1��$	��224��$	��Top=�$��447,340,599,0q��� -   $ card2��$	��224��$	��Top=�$��669,340,375,0q��� -   $ card3��$	��224��$	��Top=�$��891,340,156,0q��� -   $ About��$��About��$��55��$��694,605,239,0q�$	��Top=�$ 0.133,0.304&�$��1q�$��Viner Hand ITC)�$��26.667(����	#FF7E2121$	��110��   $ 10Q�z�V� .~��� �� ��  �� Angle$ -0.148Q�T� �� -    ��Name$ label1��$�� ��$
��Left=�$	��196��$��994,484,-78,0q�$��Center=�$	��276��$��18(�$��Viner Hand ITC)����	#FF7E2121$��Center=�$y�Hidden=� K� ZIndex$	 999������ $ 0.5,1&� � MappingMode$ RelativeToBoundingBox=�$	 0.5,0&�.��� $
 Black��� $
 White��� $
 	#FFCDCDCD��$ 0.623Q�   $ 10Q��� -   $ label2��$�� ��$
��Left=�$	��170��$��517,340,0,180q�$��Center=�$	��430�����	#FF7E2121$��18(�$y�Hidden=�$	 999��$��2q����� $ 0.5,1&�$	 0.5,0&�.��� $
 Black��� $
 	#FFFDFDFD��� $
 	#FFCDCDCD��$ 0.665Q�