using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderReplace2_StringBuilderReplace2_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderReplace2_StringBuilderReplace2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderReplace2\\StringBuilderReplace2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
