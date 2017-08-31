using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_objectmodel_callnonvirt_callnonvirt_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_callnonvirt_callnonvirt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\callnonvirt\\callnonvirt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
