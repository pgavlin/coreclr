using CoreclrTestLib;
using Xunit;

namespace GC_Coverage
{
    public class _LargeObjectAlloc_LargeObjectAlloc_
    {
        [Fact]
        public void _LargeObjectAlloc_LargeObjectAlloc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Coverage\\LargeObjectAlloc\\LargeObjectAlloc.cmd");
        }
    }
}
