using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        
        static void Main(string[] args)
        {
            HammingDistanceInt ham = new HammingDistanceInt();
            Console.WriteLine("Hey");
            Console.WriteLine("Hamming Distance between: 15 and 25 is: " + ham.hammingDistance(15, 25));
            Console.ReadKey();

            MergeBinaryTree merge = new MergeBinaryTree();
            merge.run();
            Console.WriteLine("Merging");
            Console.ReadKey();

            SumArrayPairs sort = new SumArrayPairs();
            Console.WriteLine(sort.ArrayPairSum(new int[] { 1, 4, 3, 2 }));
            Console.ReadKey();

            ReverseInPosition rev = new ReverseInPosition();
            String reverse = "enuk$)g*)(mex%y*ocdafa)ev%konbr(ucvu*kjh$kyz*djrk)rniq##jbqtwhu*r&q#gsd#ivkni (xkpffov(frqu)!&sf&stbw)@s! eq&tj)vguf!y$sstm^! @mx%khlj$jpqs*uxwxvgu vjmlw^ubivqyyljta%q&$f@mcvc&(owvgyehq#qph*fak tqxtey kexylyiwh%!bxpcqo@zgg&tklpw%phs)cbo@(&^^wn w*xhpxa@d!!vwavwqchbfmpl&z@$kztz#nc%@!tv$htr!&d(wbj^tcfpu!z)!hyf^&sc!c)z%bgufbj#obhlykh ih$vxc*to#*wombce*eo)pqftfps^c(&kf%clklc f&$murkgdhnos$%ovvaqc&las%r%s*x^cpqvk&xlbmxejlsyt^(ck$ @)ks$i!dotdz)skwc&s^zk!ma!z@ymd%d)(flj^)va*tr^xnjgd!x b!al&bvewa#wtr^pov v$aie%x&&bx#@mnwrvu&^v$je(#se&y)x$wmgzmi!%eixawazf%*g$obyggoybw#ygjg**u(it@^b)@raa#ua(w*wxensgd u(a%qinf#wgoxt(q!&rz)ktpuqrjswqr^kispf*gzv#nkyg icd)xfhdpwwvm@i$%&ov(xkbe)igwajs@v)nepqtbjtk $dexm*bapttglgj$azwcaobdj&$ol#jnoq(f&twe@ulovnliefy%(%uncco%z#%%&w@xanjxdd";
            Console.WriteLine(reverse);
            Console.WriteLine(rev.reverseInPosition(reverse));
            Console.ReadKey();

        }

        
    }
}
