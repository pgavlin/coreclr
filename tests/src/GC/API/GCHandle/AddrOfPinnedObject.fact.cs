using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GCHandle_AddrOfPinnedObject_AddrOfPinnedObject_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_AddrOfPinnedObject_AddrOfPinnedObject_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GCHandle\\AddrOfPinnedObject\\AddrOfPinnedObject.cmd");
        }
    }
}
