using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_objectmodel_callnonvirt_callnonvirt_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_callnonvirt_callnonvirt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\callnonvirt\\callnonvirt.cmd");
        }
    }
}
