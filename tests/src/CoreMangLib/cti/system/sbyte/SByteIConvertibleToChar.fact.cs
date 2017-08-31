using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_sbyte_SByteIConvertibleToChar_SByteIConvertibleToChar_
    {
        [OuterLoop]
        [Fact]
        public void _system_sbyte_SByteIConvertibleToChar_SByteIConvertibleToChar_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\sbyte\\SByteIConvertibleToChar\\SByteIConvertibleToChar.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
