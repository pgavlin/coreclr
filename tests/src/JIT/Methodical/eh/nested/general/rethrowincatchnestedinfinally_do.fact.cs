using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_rethrowincatchnestedinfinally_do_rethrowincatchnestedinfinally_do_
    {
        [Fact]
        public void _eh_nested_general_rethrowincatchnestedinfinally_do_rethrowincatchnestedinfinally_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\rethrowincatchnestedinfinally_do\\rethrowincatchnestedinfinally_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
