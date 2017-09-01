using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_objectmodel_ldvirtftn_ldvirtftn_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_ldvirtftn_ldvirtftn_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\ldvirtftn\\ldvirtftn.cmd");
        }
    }
}
