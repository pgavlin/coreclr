using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderCapacity_cti_StringBuilderCapacity_cti_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderCapacity_cti_StringBuilderCapacity_cti_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderCapacity_cti\\StringBuilderCapacity_cti.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
