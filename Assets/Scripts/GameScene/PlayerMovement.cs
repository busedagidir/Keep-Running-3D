using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _playerRB;

    private float _sideSpeed = 120.0f;
    private float _forwardSpeed = 60.0f;

    void FixedUpdate() //Fizikle uğraşacaksan update kullanmican derdi Brackeys :/ RIP
    {
        #region Yan Hareket
        Vector3 _sideDir = Vector3.zero;

        // Sağ-Sol için sadece X eksenine ihtiyacımız var
        _sideDir.x = Input.acceleration.x;

        // Fazla döndürme fazla kaydırmasın diye birime sabitleme
        if (_sideDir.sqrMagnitude > 1)
        {
            _sideDir.Normalize();
        }

        // Zamana sabitleme
        _sideDir *= Time.deltaTime;

        // Sağ ve sol hareketi
        transform.Translate(_sideDir * _sideSpeed);
        #endregion

        #region Düz Hareket
        //Devamlı ileri gitme
        _playerRB.AddForce(0, 0, _forwardSpeed);

        //Dokunma varsa
        if (Input.touchCount > 0 && _playerRB.velocity.z >= 10f) // Tersi kuvvet olduğu için hızımız belli bir seviyenin altına düşmesin.
        {
            _playerRB.AddForce(0, 0, -(_forwardSpeed * 3)); // 3 katı kuvvet uygun geldi malum hızımız devamlı artıyor force uyguladığımız için :)
        }

        //Hızımızı bilelim
        //Debug.Log(_playerRB.velocity);

        //Düştüğünde yenilesin
        if (_playerRB.position.y <= -25f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        #endregion
    }
}