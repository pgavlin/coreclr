using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderctor2_StringBuilderctor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderctor2_StringBuilderctor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderctor2\\StringBuilderctor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
