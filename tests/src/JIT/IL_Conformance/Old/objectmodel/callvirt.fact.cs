using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_objectmodel_callvirt_callvirt_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_callvirt_callvirt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\callvirt\\callvirt.cmd");
        }
    }
}
