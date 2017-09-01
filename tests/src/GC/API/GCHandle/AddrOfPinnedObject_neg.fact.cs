using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GCHandle_AddrOfPinnedObject_neg_AddrOfPinnedObject_neg_
    {
        [Fact]
        public void _GCHandle_AddrOfPinnedObject_neg_AddrOfPinnedObject_neg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GCHandle\\AddrOfPinnedObject_neg\\AddrOfPinnedObject_neg.cmd");
        }
    }
}
