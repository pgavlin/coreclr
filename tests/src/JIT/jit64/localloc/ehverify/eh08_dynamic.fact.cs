using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh08_dynamic_eh08_dynamic_
    {
        [Fact]
        public void _localloc_ehverify_eh08_dynamic_eh08_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh08_dynamic\\eh08_dynamic.cmd");
        }
    }
}
