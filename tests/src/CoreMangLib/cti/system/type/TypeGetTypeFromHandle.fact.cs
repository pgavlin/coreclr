using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_type_TypeGetTypeFromHandle_TypeGetTypeFromHandle_
    {
        [OuterLoop]
        [Fact]
        public void _system_type_TypeGetTypeFromHandle_TypeGetTypeFromHandle_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\type\\TypeGetTypeFromHandle\\TypeGetTypeFromHandle.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
