using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int_Int32IConvertibleToSingle_Int32IConvertibleToSingle_
    {
        [OuterLoop]
        [Fact]
        public void _system_int_Int32IConvertibleToSingle_Int32IConvertibleToSingle_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int\\Int32IConvertibleToSingle\\Int32IConvertibleToSingle.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
