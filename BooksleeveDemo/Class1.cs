using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSleeve;
using NUnit.Framework;

namespace BooksleeveDemo
{

    public class Class1
    {
        [Test]
        public void test_writes()
        {
            for (int i = 0; i < 10000; i++)
            {
                using (var conn = new RedisConnection("localhost"))
                {
                    conn.Open();

                    conn.Strings.Set(0, i.ToString(), payload);
                }    
            }

        }


        [Test]
        public void test_reads()
        {
            for (int i = 0; i < 10000; i++)
            {
                using (var conn = new RedisConnection("localhost"))
                {
                    conn.Open();

                    string s = conn.Strings.GetString(0, i.ToString()).Result;

                    Console.WriteLine(s.Substring(0, 30));
                }
            }
        }

    
        private string payload = @"[
    {
        'id': 0,
        'guid': 'd86ce913-5a22-4dba-aec4-02a3ba38a28c',
        'isActive': true,
        'balance': '$2,380.00',
        'picture': 'http://placehold.it/32x32',
        'age': 33,
        'name': 'Magdalena Holland',
        'gender': 'female',
        'company': 'Reversus',
        'email': 'magdalenaholland@reversus.com',
        'phone': '+1 (827) 520-3473',
        'address': '465 Bayard Street, Sunwest, Arizona, 4183',
        'about': 'Ea voluptate deserunt aute excepteur enim reprehenderit. Aute anim eu nostrud mollit et pariatur magna ut sunt sunt ullamco et consequat. Veniam cillum nisi nulla irure eiusmod excepteur laboris velit. Fugiat sint magna voluptate aliquip. Quis occaecat aute excepteur tempor. Est consectetur nostrud amet veniam adipisicing officia occaecat consequat elit do laborum nisi ad. Est ut eu amet non dolor tempor.\r\n',
        'registered': '1992-10-12T15:02:10 -01:00',
        'latitude': -63.635865,
        'longitude': -157.21271,
        'tags': [
            'exercitation',
            'proident',
            'nulla',
            'sunt',
            'est',
            'cupidatat',
            'do'
        ],
        'friends': [
            {
                'id': 0,
                'name': 'Jannie Saunders'
            },
            {
                'id': 1,
                'name': 'Krystal Roth'
            },
            {
                'id': 2,
                'name': 'Margo Hogan'
            }
        ],
        'randomArrayItem': 'lemon'
    },
    {
        'id': 1,
        'guid': 'b11fc9d5-9f18-441f-8648-52a9ba90074f',
        'isActive': true,
        'balance': '$1,914.00',
        'picture': 'http://placehold.it/32x32',
        'age': 22,
        'name': 'Nicole Roberts',
        'gender': 'female',
        'company': 'Exosis',
        'email': 'nicoleroberts@exosis.com',
        'phone': '+1 (830) 539-3762',
        'address': '887 Madoc Avenue, Babb, Pennsylvania, 4459',
        'about': 'Elit eiusmod eu elit commodo sunt do ea. Proident adipisicing adipisicing culpa ad tempor et aliqua qui adipisicing officia ea. Et sint dolore eiusmod esse ipsum incididunt commodo. Dolore laborum laboris irure esse laboris aute ipsum. Elit reprehenderit fugiat in exercitation velit consequat culpa culpa minim est ad. Proident excepteur fugiat veniam aute est ipsum eiusmod duis.\r\n',
        'registered': '1988-04-19T02:50:56 -01:00',
        'latitude': -41.992159,
        'longitude': -116.657455,
        'tags': [
            'deserunt',
            'sint',
            'consectetur',
            'cillum',
            'voluptate',
            'aliqua',
            'eu'
        ],
        'friends': [
            {
                'id': 0,
                'name': 'Juana Beard'
            },
            {
                'id': 1,
                'name': 'Adams Grant'
            },
            {
                'id': 2,
                'name': 'Janna Gallegos'
            }
        ],
        'randomArrayItem': 'lemon'
    },
    {
        'id': 2,
        'guid': 'd11c62ee-47ba-4dab-96dd-403086b09683',
        'isActive': true,
        'balance': '$1,518.00',
        'picture': 'http://placehold.it/32x32',
        'age': 27,
        'name': 'Genevieve Holman',
        'gender': 'female',
        'company': 'Aquoavo',
        'email': 'genevieveholman@aquoavo.com',
        'phone': '+1 (892) 457-2021',
        'address': '914 Vanderveer Place, Gracey, Nevada, 905',
        'about': 'Fugiat laborum mollit amet in occaecat excepteur sit duis. Ea nulla in veniam enim quis. Dolore occaecat sint est id eu eu ex id duis cillum ea. Nostrud commodo qui laborum veniam nostrud qui labore. Aliqua veniam ipsum aliquip eu qui esse. Labore qui officia quis incididunt commodo anim.\r\n',
        'registered': '1989-02-10T09:42:54 -00:00',
        'latitude': 70.953871,
        'longitude': 17.575551,
        'tags': [
            'commodo',
            'incididunt',
            'ea',
            'ex',
            'velit',
            'commodo',
            'minim'
        ],
        'friends': [
            {
                'id': 0,
                'name': 'Marsha Mcneil'
            },
            {
                'id': 1,
                'name': 'Avila Sargent'
            },
            {
                'id': 2,
                'name': 'Norris Mejia'
            }
        ],
        'randomArrayItem': 'apple'
    },
    {
        'id': 3,
        'guid': 'ca6b50ab-1da9-460c-9dd0-683b81c03e20',
        'isActive': true,
        'balance': '$3,360.00',
        'picture': 'http://placehold.it/32x32',
        'age': 31,
        'name': 'Janice Trevino',
        'gender': 'female',
        'company': 'Teraprene',
        'email': 'janicetrevino@teraprene.com',
        'phone': '+1 (803) 499-2185',
        'address': '510 Polar Street, Eden, North Dakota, 7697',
        'about': 'Excepteur velit ad consectetur labore minim ea magna sit est dolor ipsum quis. Amet enim eu qui qui sint nulla tempor aute magna enim sunt. Mollit laboris anim sit tempor.\r\n',
        'registered': '1989-06-07T07:29:32 -01:00',
        'latitude': 89.031826,
        'longitude': -178.515816,
        'tags': [
            'nostrud',
            'velit',
            'cupidatat',
            'ea',
            'aliquip',
            'voluptate',
            'quis'
        ],
        'friends': [
            {
                'id': 0,
                'name': 'Mable Gibbs'
            },
            {
                'id': 1,
                'name': 'Dale Francis'
            },
            {
                'id': 2,
                'name': 'Schroeder Donaldson'
            }
        ],
        'randomArrayItem': 'apple'
    },
    {
        'id': 4,
        'guid': 'e7778eba-bf3d-49e1-a906-eb2600172a9d',
        'isActive': false,
        'balance': '$3,257.00',
        'picture': 'http://placehold.it/32x32',
        'age': 31,
        'name': 'Marina Lamb',
        'gender': 'female',
        'company': 'Quailcom',
        'email': 'marinalamb@quailcom.com',
        'phone': '+1 (822) 559-3521',
        'address': '673 Oak Street, Calverton, Hawaii, 7499',
        'about': 'Adipisicing aliqua id est laboris nostrud exercitation. Minim dolore Lorem nisi ipsum aliquip deserunt aute amet dolor voluptate. Enim nulla reprehenderit nostrud aute aliquip fugiat exercitation nostrud ad.\r\n',
        'registered': '1998-10-27T13:30:01 -00:00',
        'latitude': -12.54624,
        'longitude': 46.502637,
        'tags': [
            'esse',
            'aute',
            'culpa',
            'laboris',
            'est',
            'aliquip',
            'deserunt'
        ],
        'friends': [
            {
                'id': 0,
                'name': 'Stephanie Singleton'
            },
            {
                'id': 1,
                'name': 'Montgomery Hawkins'
            },
            {
                'id': 2,
                'name': 'Chasity Gilbert'
            }
        ],
        'randomArrayItem': 'apple'
    }
]";
    
    }




}
