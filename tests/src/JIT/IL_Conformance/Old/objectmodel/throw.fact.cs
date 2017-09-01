using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_objectmodel_throw_throw_
    {
        [Fact]
        public void _Old_objectmodel_throw_throw_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\throw\\throw.cmd");
        }
    }
}
