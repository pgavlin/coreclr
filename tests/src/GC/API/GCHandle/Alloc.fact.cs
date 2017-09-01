using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GCHandle_Alloc_Alloc_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_Alloc_Alloc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Alloc\\Alloc.cmd");
        }
    }
}
