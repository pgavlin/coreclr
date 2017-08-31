using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _Rootmem_rootmem_rootmem_
    {
        [Fact]
        public void _Rootmem_rootmem_rootmem_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\Rootmem\\rootmem\\rootmem.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
