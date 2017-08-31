using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderAppend_StringBuilderAppend_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderAppend_StringBuilderAppend_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderAppend\\StringBuilderAppend.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
