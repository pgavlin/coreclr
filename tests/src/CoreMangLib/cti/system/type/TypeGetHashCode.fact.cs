using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_type_TypeGetHashCode_TypeGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_type_TypeGetHashCode_TypeGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\type\\TypeGetHashCode\\TypeGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
