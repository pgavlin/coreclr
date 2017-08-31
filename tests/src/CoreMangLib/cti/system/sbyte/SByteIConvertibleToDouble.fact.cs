using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_sbyte_SByteIConvertibleToDouble_SByteIConvertibleToDouble_
    {
        [OuterLoop]
        [Fact]
        public void _system_sbyte_SByteIConvertibleToDouble_SByteIConvertibleToDouble_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\sbyte\\SByteIConvertibleToDouble\\SByteIConvertibleToDouble.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
