using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_type_TypeMakeByRefType_TypeMakeByRefType_
    {
        [OuterLoop]
        [Fact]
        public void _system_type_TypeMakeByRefType_TypeMakeByRefType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\type\\TypeMakeByRefType\\TypeMakeByRefType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
