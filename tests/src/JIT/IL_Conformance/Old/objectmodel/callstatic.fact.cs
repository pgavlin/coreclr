using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_objectmodel_callstatic_callstatic_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_callstatic_callstatic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\callstatic\\callstatic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
