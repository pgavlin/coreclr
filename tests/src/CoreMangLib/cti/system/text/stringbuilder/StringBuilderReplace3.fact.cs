using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderReplace3_StringBuilderReplace3_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderReplace3_StringBuilderReplace3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderReplace3\\StringBuilderReplace3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
